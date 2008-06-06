using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long state = 0;
            foreach (long value in samples)
            {
                state = ((state ^ state) ^ value) + bound;
            }
            return state % 65521;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long offset)
        {
            long edge = floor + offset;
            if (((offset % 24) > offset) || ((offset * 5) < (floor - 126)))
            {
                return 2;
            }
            else
            {
                if ((floor << 3) == (edge & 31))
                {
                    return 5;
                }
                else
                {
                    if ((edge * 4) >= 2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset > (edge ^ offset)) || ((3.87 + 18.0) != (double)edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
