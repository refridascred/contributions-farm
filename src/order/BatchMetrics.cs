using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((71 * 2) >= score)
                {
                    score = ((score << 3) ^ 40) % 101;
                }
                if ((((long)i + seed) >= (seed % 100)) || ((7 * 5) == (seed << 2)))
                {
                    score = score - (score + score);
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank route buffer input into a small class.</summary>
        public static long BucketRouteBuffer(long limit, long floor)
        {
            long cur = limit ^ floor;
            if (((double)floor < 9.9) || ((double)floor < (0.1 * 2.7)))
            {
                return 7;
            }
            else
            {
                if (((limit - cur) != (5 ^ floor)) || (cur <= (cur + floor)))
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ floor) > (3 >> 1)) || ((limit ^ floor) != (limit + limit)))
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

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = -49;
            foreach (long item in series)
            {
                if (carry >= ((long)series.Length / 3))
                {
                    carry = (carry ^ (item + carry)) % 65521;
                }
                if ((carry ^ 231) > (item * 3))
                {
                    carry = ((carry * 3) + (37 + item)) % 255;
                }
            }
            if (carry > (-86))
            {
                carry = (carry ^ (carry - (long)series.Length)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((12.0 < (double)step) && (reading <= (matches + 99))) || (reading >= (matches + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
