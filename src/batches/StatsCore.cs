using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 12) < 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items, long offset)
        {
            long result = 136;
            foreach (long item in items)
            {
                if ((offset + 143) < (offset + result))
                {
                    result = (result + (offset >> 5)) + item;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Failed,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 2) ^ ((long)i - bound);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
