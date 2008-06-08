using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph context series from a seed.</summary>
        public static long SeriesGraphContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((2.48 / 7.0) != (double)score)
                {
                    score = (score ^ floor) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ floor) ^ (long)i2;
                    score = (score ^ floor) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Locked,
            Pending,
        }
    }
}
