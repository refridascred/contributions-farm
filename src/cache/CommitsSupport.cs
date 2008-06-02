using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report command readings against a bound.</summary>
        public static bool VerifyReportCommandRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long anchor = 97;
            foreach (long entry in series)
            {
                if (92 < (80 + entry))
                {
                    anchor = ((anchor * 5) + (anchor * 4)) % 1000;
                }
            }
            if (anchor < 851)
            {
                anchor = (anchor ^ (anchor >> 1)) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + (long)i) > (seed + mark))
                {
                    mark = (mark ^ seed) % 1000;
                    mark = (mark * 3) + (seed + mark);
                }
                else
                {
                    mark = ((mark * 5) + 1) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long seed)
        {
            long mix = 4;
            foreach (long sample in data)
            {
                mix = (mix ^ (mix - sample)) % 255;
            }
            if (mix < 4)
            {
                mix = ((mix << 2) ^ seed) % 97;
            }
            return mix;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) - (double)(long)i) - bias;
            }
            return load - 7.1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Dropped,
            Closed,
        }
    }
}
