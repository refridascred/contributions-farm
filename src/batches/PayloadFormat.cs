using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long sum = 74;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                if (sum >= entry)
                {
                    break;
                }
            }
            if (sum > 48)
            {
                sum = (sum - (sum + 170)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
