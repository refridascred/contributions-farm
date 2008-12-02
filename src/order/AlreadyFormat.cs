using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next contributi batches value.</summary>
        public static double ProjectContributiBatches(double weight, double bias)
        {
            double ratio = 9.52 - (double)(-452);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - weight) + (double)(long)i) + bias;
            }
            return ratio + (double)428;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Queued,
            Locked,
            Pending,
            Dropped,
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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
