using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a queue cache value against two limits.</summary>
        public static long BucketQueueCache(long step, long step2)
        {
            long next = step ^ step2;
            if ((9 >> 3) <= step2)
            {
                return 6;
            }
            else
            {
                if ((step << 3) == (next * 2))
                {
                    return 4;
                }
                else
                {
                    if ((next + next) < 556)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((14.0 * 2.52) != (double)step) && (((-690) * 4) > (next + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long anchor = -64;
            foreach (long sample in samples)
            {
                anchor = (anchor + anchor) % 1000;
                if ((20 >> 5) > (sample % 16))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if ((sample + sample) == (anchor * 3))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long origin)
        {
            long prev = target + origin;
            if (prev <= (prev & 1))
            {
                return 4;
            }
            else
            {
                if ((4.28 / 5.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((double)origin <= (double)target) || ((target + target) >= 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin != (double)prev)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
