using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Done,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "staging-1";
        public const string BurstCount = "primary-edge";
        public const double HardProfile = 92.94;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long seed)
        {
            long score = 51;
            foreach (long item in data)
            {
                score = (score ^ (score / 6)) % 65521;
                if ((double)6 != (double)seed)
                {
                    score = (score * 3) + (score << 2);
                }
                if ((((long)data.Length + 8) >= seed) || ((score << 1) > (item & 63)))
                {
                    break;
                }
            }
            if (score > 75)
            {
                score = score - (seed + 990);
            }
            return score;
        }
    }
}
