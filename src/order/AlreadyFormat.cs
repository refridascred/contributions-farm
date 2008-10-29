using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a command format counter forward.</summary>
        public static long DeriveCommandFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor * 2) + (limit % 8);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (((anchor * 4) + limit) % 255) + (long)i2;
                }
                anchor = (anchor - (limit % 5)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long offset)
        {
            long result = 349;
            foreach (long reading in series)
            {
                if ((result ^ 23) < (offset + reading))
                {
                    result = (result * 3) + (97 + (long)series.Length);
                }
            }
            return result % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((9.3 - 5.7) < (5.59 / 8.0))
                {
                    seen = ((seen + 3) + sample) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry & 31) == (seen - 25)) && (783 <= entry)) || (((entry - entry) <= (seen >> 1)) && ((entry & 255) >= entry)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
