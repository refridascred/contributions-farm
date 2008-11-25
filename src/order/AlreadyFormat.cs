using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine profile tools values into a single score.</summary>
        public static long DigestProfileTools(long[] series, long floor)
        {
            long mix = 87;
            foreach (long item in series)
            {
                if ((item + 5) != (item + item))
                {
                    mix = (((mix * 5) + (28 ^ mix)) % 97) - floor;
                }
                else
                {
                    long step = mix;
                    mix = (mix - step) % 97;
                }
                mix = (mix + (item + item)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Done,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Rank editor stats input into a small class.</summary>
        public static long GradeEditorStats(long step, long bound)
        {
            long delta = step - bound;
            if (!(9 <= (step & 15)))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) > delta)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits - datum) < datum) || ((datum >> 2) < (datum + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
