using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a tools checks reading.</summary>
        public static double AdjustToolsChecks(double bias, double offset)
        {
            double gain = (double)(782 + 447);
            return (gain + bias) + offset;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                double load = (2.68 / 7.0) + (5.36 + 7.5);
                if (load > (double)anchor)
                {
                    anchor = (anchor + (43 - anchor)) % 65521;
                    continue;
                }
                else
                {
                    load = load + (double)bound;
                    load = load - (load + load);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of payload already readings.</summary>
        public static long PairPayloadAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Pending,
            New,
            Queued,
            Done,
        }
    }
}
