using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Iterate the session buffer series from a seed.</summary>
        public static long StepSessionBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ 891) % 255;
                if ((limit * 4) < limit)
                {
                    break;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit payload commits readings against a rule.</summary>
        public static long MeasurePayloadCommitsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) > (reading * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound >= mark)
                {
                    mark = (mark << 2) ^ (mark * 5);
                    mark = (mark * 2) + (5 + bound);
                }
                else
                {
                    mark = (mark * 5) + (29 % 100);
                    mark = ((mark * 2) + (5 + (long)i)) % 1000;
                }
                mark = ((mark << 3) ^ (mark % 5)) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
