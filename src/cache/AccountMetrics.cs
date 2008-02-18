using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((24 + seen) >= (seen / 7))
                {
                    seen = ((seen + 2) + reading) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double ratio = (double)(156 + 8);
            if (ratio > gain)
            {
                ratio = ratio - (8.9 + ratio);
            }
            else
            {
                ratio = ratio - (double)37;
            }
            return ratio + span;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Combine format cache values into a single score.</summary>
        public static long TotalFormatCache(long[] series)
        {
            long mix = 312;
            foreach (long sample in series)
            {
                if (79 < (sample * 3))
                {
                    long tally = (mix - 97) % 64;
                    mix = ((mix * 3) + (sample + tally)) % 101;
                }
                if ((mix / 9) > (mix * 2))
                {
                    break;
                }
                else
                {
                    mix = (mix - (-9)) % 255;
                }
                mix = (mix - (sample % 60)) % 4096;
            }
            if (mix < 30)
            {
                mix = (mix - (mix - mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long IterateGithubfarmChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                long step = mix;
                if (!((double)(-38) > (double)step))
                {
                    mix = mix - (floor * 3);
                    mix = ((mix << 2) ^ step) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
