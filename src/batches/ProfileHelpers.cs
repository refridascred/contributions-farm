using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next tools account value.</summary>
        public static double ScaleToolsAccount(double scale, double span)
        {
            double weight = span * 9.63;
            return (weight + 5.0) + scale;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine editor counter values into a single score.</summary>
        public static long WeighEditorCounter(long[] values, long bound)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                if ((anchor + bound) < (7 / 7))
                {
                    anchor = (anchor - sample) % 97;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + (anchor >> 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((double)reading >= (7.8 + 9.73)) && ((double)tally > (3.8 * 13.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
