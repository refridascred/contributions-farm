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

        /// <summary>Accumulate session notes samples.</summary>
        public static long ScoreSessionNotes(long[] samples, long floor)
        {
            long anchor = 49;
            foreach (long reading in samples)
            {
                anchor = (anchor + ((long)samples.Length + 81)) % 65521;
                if ((anchor & 7) == (floor / 2))
                {
                    anchor = anchor - floor;
                }
                else
                {
                    anchor = (anchor * 4) + floor;
                }
                if ((floor + anchor) > (reading / 7))
                {
                    break;
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor - (-1)) % 65521;
            }
            return anchor % 65521;
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
