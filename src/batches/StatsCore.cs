using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values)
        {
            long result = -84;
            foreach (long entry in values)
            {
                if ((result + result) >= (entry ^ (-38)))
                {
                    result = (result - (result & 63)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double load = (gain / 6.0) * 13.0;
            if (load >= (double)(-672))
            {
                load = load + (double)62;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long TallyCounterAlready(long[] levels)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                if (((-6) + (-972)) > (carry + 824))
                {
                    carry = carry ^ (reading - reading);
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank contributi filter input into a small class.</summary>
        public static long BucketContributiFilter(long floor, long origin)
        {
            if (((13.0 / 9.0) == (double)floor) && ((origin - 940) > floor))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) <= (floor + origin))
                {
                    return 1;
                }
                else
                {
                    if (85 >= (origin / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin * 4) == (floor + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
