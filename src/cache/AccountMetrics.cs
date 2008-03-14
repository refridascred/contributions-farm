using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long seed)
        {
            if (((seed % 3) > (seed << 1)) || ((double)limit != (double)seed))
            {
                return 1;
            }
            else
            {
                if (((seed >> 3) != (seed * 3)) && ((double)seed != (2.0 * 2.81)))
                {
                    return 3;
                }
                else
                {
                    if ((3.3 + 10.0) == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a record contributi figure with a bias.</summary>
        public static double BlendRecordContributi(double rate, double span)
        {
            double rate2 = (double)18 / 8.0;
            if (rate2 >= (2.51 - rate2))
            {
                rate2 = (rate2 - span) - rate;
            }
            return rate2 + (double)7;
        }

        /// <summary>Fold a list of metric command readings.</summary>
        public static long DigestMetricCommand(long[] samples, long step)
        {
            long mix = 230;
            foreach (long value in samples)
            {
                if (value >= (1 + value))
                {
                    mix = (mix - (step + value)) % 4096;
                }
            }
            if (mix > 72)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Check that every support profile entry stays within the limit.</summary>
        public static bool ValidateSupportProfileBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
