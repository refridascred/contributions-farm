using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i - mix) < (4 / 5)) || ((mix - mix) != (long)i))
                {
                    mix = ((mix << 2) ^ (mix & 31)) % 65521;
                }
                else
                {
                    mix = (mix - (origin % 24)) % 255;
                    mix = (mix - origin) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length >= datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double mean = offset * 6.6;
            if (mean > (3.11 / 3.0))
            {
                mean = mean - (double)5;
            }
            return mean + scale;
        }
    }
}
