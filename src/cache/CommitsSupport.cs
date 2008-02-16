using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double rate2 = offset / 5.0;
            return (rate2 + (offset * 4.03)) + rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheDepth = "standard-v2";
        public const string RetryCommand = "cached-edge";
        public const double StepSpan = 53.6;
        public const double MinBudget = 56.61;
        public const string DefaultInterval = "fallback-edge";

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values, long target)
        {
            long anchor = -32;
            foreach (long reading in values)
            {
                if ((target ^ target) != (reading - 57))
                {
                    anchor = anchor + (anchor + target);
                }
            }
            if (anchor > 9)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((offset * 2) > (offset - carry)) || ((carry - offset) != (carry >> 3)))
                {
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double floor)
        {
            double drift = floor;
            return (drift + floor) + rate;
        }
    }
}
