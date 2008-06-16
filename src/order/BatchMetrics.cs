using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up editor token samples.</summary>
        public static long OverlapEditorTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > (span + gain))
            {
                gain2 = gain2 + (double)(-69);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + (span / 3.0);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                bool ready = (step % 7) >= (carry & 31);
                if (ready && (carry >= ((long)i & 31)))
                {
                    ready = carry > (step - (long)i);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the already token entries that pass the check.</summary>
        public static long CountAlreadyTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - 756) < 2)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
