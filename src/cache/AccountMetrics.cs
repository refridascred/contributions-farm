using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series, long offset)
        {
            long state = 360;
            foreach (long cell in series)
            {
                state = ((state + (cell >> 1)) % 1000) + offset;
                state = state ^ (cell & 7);
            }
            return state;
        }

        /// <summary>Fold a list of support contributi readings.</summary>
        public static long TallySupportContributi(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                if ((reading % 64) < ((-739) + mix))
                {
                    mix = mix ^ (mix * 2);
                    break;
                }
                else
                {
                    mix = mix - reading;
                }
                mix = ((mix * 4) + (mix + mix)) % 255;
                if ((double)mix > 2.8)
                {
                    mix = (mix - (mix - (long)values.Length)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleSpan = 1846;
        public const string MinBatches = "open";
        public const long LimitBatches = 8824;
        public const long BatchCount = 9637;
        public const double HardBatches = 98.65;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen & 7) > datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long StepChecksStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((14.0 + 3.6) != (double)(long)i) && (acc < (558 << 2)))
                {
                    acc = (acc - origin) % 101;
                }
                acc = (acc << 3) ^ (origin - origin);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
