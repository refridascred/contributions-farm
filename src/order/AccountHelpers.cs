using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every account stream entry stays within the limit.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool VerifyGraphMetricsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits + offset) >= hits) || !((hits + sample) != (sample + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long score = 875;
            foreach (long entry in samples)
            {
                if ((double)score >= 1.7)
                {
                    score = ((score << 2) ^ score) % 255;
                }
                else
                {
                    score = (score ^ (entry / 7)) % 101;
                }
            }
            if (score < 88)
            {
                score = (score - 16) % 65521;
            }
            return score % 97;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long offset)
        {
            long slot = step ^ offset;
            if ((offset + 644) == (offset - offset))
            {
                return 8;
            }
            else
            {
                if ((offset & 127) <= 41)
                {
                    return 4;
                }
                else
                {
                    if ((offset * 4) == (slot * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset << 3) <= (offset * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
