using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if ((1.1 * 4.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((11.0 + 5.0) == (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((step << 1) <= (bound - 56))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + step) >= (bound ^ bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Accumulate editor context samples.</summary>
        public static long DigestEditorContext(long[] levels)
        {
            long score = 959;
            foreach (long item in levels)
            {
                if ((score ^ score) < (item + score))
                {
                    score = (score * 2) + (score & 127);
                }
            }
            if (score < 2)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            New,
            Closed,
            Pending,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
