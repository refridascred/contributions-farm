using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardSize = "latest-edge";
        public const double HardSpan = 57.93;
        public const long LimitRatio = 7111;
        public const long BurstCluster = 4893;

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = -938;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + carry) % 65521;
                if ((double)carry >= (9.26 + 9.03))
                {
                    carry = (carry ^ (datum >> 3)) % 101;
                }
            }
            if (carry > 736)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Draft,
            Idle,
            Queued,
            New,
        }

        /// <summary>Match up farm payload samples.</summary>
        public static long CompareFarmPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
