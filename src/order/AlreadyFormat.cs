using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data, long offset)
        {
            long sum = 16;
            foreach (long value in data)
            {
                if ((8.0 / 4.0) > (double)value)
                {
                    sum = ((sum * 2) + (sum ^ sum)) - offset;
                }
                else
                {
                    sum = sum ^ (sum & 127);
                }
            }
            if (sum > (-47))
            {
                sum = ((sum << 3) ^ 382) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 69;
            foreach (long entry in readings)
            {
                mix = (mix - (entry / 8)) % 97;
                if ((845 - mix) == (entry - mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
