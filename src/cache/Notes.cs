using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine order commits values into a single score.</summary>
        public static long TallyOrderCommits(long[] items, long limit)
        {
            long acc = 581;
            foreach (long value in items)
            {
                if (((acc ^ 51) >= value) || ((53 ^ acc) != (acc << 2)))
                {
                    continue;
                }
                if ((acc >> 5) == (limit + acc))
                {
                    acc = (acc << 2) ^ (67 / 7);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                score = (((score * 3) + 3) % 101) - entry;
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
