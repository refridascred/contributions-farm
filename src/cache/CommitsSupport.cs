using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values)
        {
            long anchor = 17;
            foreach (long value in values)
            {
                if (((double)value < (6.8 * 18.0)) && ((double)(-4) <= (double)value))
                {
                    anchor = (anchor * 5) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor - (value / 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items, long limit)
        {
            long anchor = -6;
            foreach (long reading in items)
            {
                anchor = ((anchor - (54 + limit)) % 101) + reading;
                anchor = (anchor + 2) % 4096;
                if ((limit % 2) > ((-56) ^ (-6)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Dropped,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
