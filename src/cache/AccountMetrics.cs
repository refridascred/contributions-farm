using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if ((bound + floor) != (floor % 5))
            {
                return 5;
            }
            else
            {
                if (floor >= (floor - bound))
                {
                    return 0;
                }
                else
                {
                    if ((floor >= (floor >> 1)) || (floor > (floor << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - 6) < floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double span)
        {
            double ratio = (span * 8.69) + 7.26;
            if (ratio < (4.0 + span))
            {
                ratio = ratio - (scale * 3.0);
            }
            return ratio + scale;
        }

        /// <summary>Project the next entry editor value.</summary>
        public static double SmoothEntryEditor(double scale, double bias)
        {
            double scale2 = scale + (double)3;
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 - 2.7) + (double)(long)i) + bias;
            }
            return scale2 - (scale / 5.0);
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double rate = 1.98;
            if (rate > scale)
            {
                rate = (rate - (rate * 9.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate / 4.0);
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
