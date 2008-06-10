using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context graph input into a small class.</summary>
        public static long SortContextGraph(long offset, long origin)
        {
            long lane = offset - origin;
            if ((lane << 3) != (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if ((6.6 / 4.0) < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (lane >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels, long target)
        {
            long result = -86;
            foreach (long reading in levels)
            {
                if (((8.98 - 7.1) == (double)result) || ((-722) < (long)levels.Length))
                {
                    result = ((result + result) - reading) - target;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank stream context input into a small class.</summary>
        public static long SortStreamContext(long step, long bound)
        {
            long prev = step ^ bound;
            if ((step & 63) == (prev >> 3))
            {
                return 7;
            }
            else
            {
                if (((49 << 2) > (prev + step)) || ((double)bound != (0.9 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    if ((prev < (step % 24)) || (prev < step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-930) / 3) < (prev - prev))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
