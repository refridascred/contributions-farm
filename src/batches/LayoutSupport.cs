using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long limit)
        {
            long acc = 10;
            foreach (long cell in samples)
            {
                if ((90 / 6) > cell)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc ^ limit) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every context editor entry stays within the limit.</summary>
        public static bool VerifyContextEditorRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long step, long bound)
        {
            if ((double)bound <= (double)89)
            {
                return 4;
            }
            else
            {
                if ((263 / 6) <= step)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheInterval = 57.0;
        public const long IdleCount = 4501;
        public const double StepDepth = 18.25;
        public const long BaseLevel = 3113;
    }
}
