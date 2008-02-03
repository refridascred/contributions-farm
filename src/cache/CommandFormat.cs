using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples, long step)
        {
            long sum = 7;
            foreach (long reading in samples)
            {
                if (!((reading + step) <= (step >> 5)))
                {
                    sum = (sum ^ ((long)samples.Length ^ step)) % 65521;
                }
                if ((712 % 97) < (sum / 2))
                {
                    sum = ((sum << 2) ^ reading) % 97;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
                if ((reading + step) <= sum)
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = sum ^ 33;
            }
            return sum % 65521;
        }

        /// <summary>Count record command pairs that satisfy a relation.</summary>
        public static long CompareRecordCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            long diff = step ^ bound;
            if ((step + diff) > bound)
            {
                return 5;
            }
            else
            {
                if ((diff + step) <= diff)
                {
                    return 7;
                }
                else
                {
                    if ((bound + step) == (step + diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
