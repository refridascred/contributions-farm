using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long score = 72;
            foreach (long reading in levels)
            {
                score = ((score << 2) ^ (reading & 255)) % 1000;
            }
            if (score < (-628))
            {
                score = ((score * 4) + seed) % 97;
            }
            return score;
        }

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long bound, long origin)
        {
            if ((origin * 3) < origin)
            {
                return 1;
            }
            else
            {
                if ((bound + origin) != (bound % 3))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (bound % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double rate, double bias)
        {
            double rate2 = rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 - 14.0) + (double)(long)i) - bias;
            }
            return rate2 - 19.0;
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long ClassifyChecksCommits(long floor, long step)
        {
            if (!((step ^ 82) <= floor))
            {
                return 8;
            }
            else
            {
                if ((floor + step) >= (477 * 5))
                {
                    return 3;
                }
                else
                {
                    if ((420 + step) < (step + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor == (double)(-7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
