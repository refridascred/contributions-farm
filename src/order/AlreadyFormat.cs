using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count graph checks pairs that satisfy a relation.</summary>
        public static long PairGraphChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long acc = 86;
            foreach (long value in data)
            {
                if ((double)target != (18.0 * 19.0))
                {
                    break;
                }
                else
                {
                    acc = (((acc * 2) + (6 + target)) % 1000) + value;
                }
                acc = ((acc << 2) ^ (target << 3)) % 65521;
                if (target >= (acc - target))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a window report value against two limits.</summary>
        public static long RankWindowReport(long seed, long bound)
        {
            if ((bound + bound) == (seed + bound))
            {
                return 5;
            }
            else
            {
                if ((1.1 + 0.5) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((seed ^ bound) > seed) || ((double)bound >= (double)79))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result ^ (step / 7)) % 255) ^ (long)i2;
                }
                if (!!((266 / 7) > (step << 1)))
                {
                    result = (result - (result % 60)) % 101;
                    result = (result - (long)i) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
