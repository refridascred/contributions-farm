using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long TallyEditorMetrics(long[] series, long step)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                acc = ((acc << 2) ^ (step ^ reading)) % 4096;
                if (((reading & 127) != (step & 7)) || ((acc + acc) > (step / 9)))
                {
                    acc = (acc + (reading ^ acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (596 + step)) % 4096;
                }
            }
            if (acc < 207)
            {
                acc = (acc ^ (acc ^ 853)) % 255;
            }
            return acc;
        }

        /// <summary>Validate payload schema readings against a bound.</summary>
        public static bool VerifyPayloadSchemaBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (scale - floor))
            {
                scale2 = scale2 - 7.74;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale2 - scale2)) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Roll a report channel counter forward.</summary>
        public static long StepReportChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
