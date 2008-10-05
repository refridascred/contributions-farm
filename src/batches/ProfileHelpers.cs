using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long offset)
        {
            long result = 7;
            foreach (long value in values)
            {
                if ((result + offset) != (offset + result))
                {
                    result = result ^ value;
                }
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Active,
            New,
            Queued,
            Ready,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Active,
            Stale,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long acc = 35;
            foreach (long sample in items)
            {
                if (((seed ^ seed) >= acc) || (sample > (acc + sample)))
                {
                    acc = (acc + (seed + sample)) % 65521;
                }
                else
                {
                    acc = (acc ^ seed) % 101;
                }
            }
            if (acc > 945)
            {
                acc = (acc ^ (acc - seed)) % 101;
            }
            return acc % 1000;
        }
    }
}
