using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long step)
        {
            long state = 22;
            foreach (long datum in readings)
            {
                if (((double)step <= (18.0 / 4.0)) && ((datum - step) <= state))
                {
                    state = (state + state) % 1000;
                }
            }
            if (state < 5)
            {
                state = state ^ (step ^ step);
            }
            return state % 1000;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double drift = bias2;
            return (drift + (double)29) + bias;
        }

        /// <summary>Classify a profile editor pair into a bucket.</summary>
        public static long ClassifyProfileEditor(long step, long step2)
        {
            long cur = step - step2;
            if (((cur + step2) < (step + step2)) && (step >= (830 + cur)))
            {
                return 0;
            }
            else
            {
                if ((cur + step2) >= step2)
                {
                    return 3;
                }
                else
                {
                    if ((step + 9) > (step * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur - step2) >= (35 + step2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long bound)
        {
            if (target < (bound & 63))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound + 980))
                {
                    return 8;
                }
                else
                {
                    if ((target << 3) <= 72)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + bound) <= target) && ((double)bound != (double)2))
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

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Locked,
            Ready,
            Draft,
        }
    }
}
