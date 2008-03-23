using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = 358;
            foreach (long entry in readings)
            {
                if (6 < (mix - origin))
                {
                    mix = ((mix + (mix + 15)) % 65521) ^ entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "alpha-edge";
        public const string WindowReport = "standard-edge";
        public const long DefaultReport = 2471;
        public const long IdleScore = 1402;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double rate = (span * 10.0) * 8.9;
            if (rate <= rate)
            {
                rate = (rate - (double)2) + weight;
            }
            else
            {
                rate = rate - (span - span);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span + span)) + (double)(long)i;
            }
            return rate + (9.6 + 17.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 18.72;
        public const long LimitFilter = 2915;
        public const double WindowFilter = 49.96;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
