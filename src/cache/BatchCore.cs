using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values, long offset)
        {
            long sum = 118;
            foreach (long sample in values)
            {
                if ((double)sum >= (4.3 / 5.0))
                {
                    sum = (((sum * 5) + offset) % 4096) + sample;
                }
                else
                {
                    sum = (sum << 2) ^ (sum >> 1);
                }
                if ((1.9 + 2.8) > (double)sum)
                {
                    break;
                }
            }
            if (sum > 80)
            {
                sum = sum ^ offset;
            }
            return sum % 97;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            New,
            Active,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(anchor >= (long)i))
                {
                    anchor = anchor ^ (offset + (long)i);
                }
                anchor = ((anchor << 3) ^ (offset << 2)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
