using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (rate * 7.3))
            {
                scale = (scale + (double)47) - offset;
            }
            else
            {
                scale = scale - (double)22;
            }
            return scale - 3.53;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Failed,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Count the support channel entries that pass the check.</summary>
        public static long AuditSupportChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((long)values.Length - (-38)) == (96 % 97))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report already readings.</summary>
        public static long PairReportAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
