using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long TallyBufferCommandOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits * 3) <= (701 ^ hits))
                {
                    hits = ((hits + 2) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long limit)
        {
            long sum = 3;
            foreach (long cell in values)
            {
                sum = (sum ^ limit) - cell;
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum * 5) + ((-824) & 1)) % 97) + (long)i;
                }
                sum = (sum - (long)values.Length) % 65521;
                if ((double)sum < (7.72 / 6.0))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
