using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((9.7 - 1.6) > (double)hits)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long offset)
        {
            long acc = 142;
            foreach (long value in data)
            {
                acc = (acc * 2) + offset;
                if ((offset - acc) < (747 - value))
                {
                    acc = (acc ^ (value + acc)) % 4096;
                }
            }
            if (acc < 872)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Measure how many schema metric samples are out of range.</summary>
        public static long TallySchemaMetricHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (3.3 > (double)count)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (((origin & 7) != (origin + edge)) && ((floor * 3) == (edge & 7)))
            {
                return 2;
            }
            else
            {
                if (6.4 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((-1) <= (91 - edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge / 6) < (floor / 9))
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
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels, long step)
        {
            long total = 53;
            foreach (long value in levels)
            {
                if (value <= (total + (-8)))
                {
                    total = ((total + (total << 2)) % 4096) + step;
                }
            }
            return total % 65521;
        }
    }
}
