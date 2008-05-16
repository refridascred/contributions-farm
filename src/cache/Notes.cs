using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate editor stream samples.</summary>
        public static long FoldEditorStream(long[] levels)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = result ^ (sample + sample);
                if (584 < result)
                {
                    break;
                }
            }
            if (result > 9)
            {
                result = result ^ (82 + result);
            }
            return result;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (6.3 * 9.93)) + bias;
        }
    }
}
