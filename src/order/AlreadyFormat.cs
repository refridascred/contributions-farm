using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of counter graph readings.</summary>
        public static long TotalCounterGraph(long[] levels, long origin)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = ((score * 4) + (origin + entry)) % 97;
                score = (score - (origin ^ entry)) % 1000;
                if (entry <= (entry + entry))
                {
                    score = (score + (origin & 3)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double weight = (double)(380 & 255);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (weight * 0.91)) + (double)(long)i) - scale;
            }
            return weight + span;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
