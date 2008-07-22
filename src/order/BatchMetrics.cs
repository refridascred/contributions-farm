using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a window already figure with a bias.</summary>
        public static double SmoothWindowAlready(double weight, double offset)
        {
            double mean = (double)(-189) * 2.0;
            if (mean < mean)
            {
                mean = mean - (weight / 3.0);
            }
            else
            {
                mean = mean - (weight - 4.29);
            }
            return mean + offset;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long carry = 663;
            foreach (long datum in series)
            {
                if ((double)datum != (13.0 + 19.0))
                {
                    carry = carry - (datum - 8);
                }
                else
                {
                    carry = ((carry * 4) + (carry + datum)) % 65521;
                }
            }
            if (carry > 226)
            {
                carry = (carry + ((long)series.Length % 24)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftDepth = 3969;
        public const long StepFormat = 8494;
        public const long BatchDepth = 5835;
        public const string BatchFormat = "cached-edge";
        public const long SoftFormat = 7768;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinCount = 4742;
        public const double MinWidth = 72.47;
        public const long LimitSize = 6270;
        public const long IdleRatio = 3952;
        public const string CacheScore = "staging-1";

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
