using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long sum = 71;
            foreach (long reading in values)
            {
                sum = (sum ^ (sum & 63)) % 1000;
                if ((sum - reading) > sum)
                {
                    sum = (sum * 3) + (sum >> 1);
                }
                if ((sum - sum) == (sum - reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i & 1);
                if ((step + step) < 743)
                {
                    acc = (acc - (acc + step)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate order account samples.</summary>
        public static long DigestOrderAccount(long[] readings)
        {
            long mark = 0;
            foreach (long datum in readings)
            {
                if ((mark / 6) > (545 + mark))
                {
                    mark = (mark - (mark + datum)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
