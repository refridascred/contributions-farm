using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Retry,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long DeriveMetricProfile(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (seed < 4)
                {
                    anchor = ((anchor * 4) + (seed % 100)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ seed) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
