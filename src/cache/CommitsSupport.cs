using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a editor window sample.</summary>
        public static long LocateEditorWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count < value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Queued,
            Active,
            Retry,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long origin)
        {
            long score = 903;
            foreach (long item in samples)
            {
                if ((origin + origin) == (origin + (long)samples.Length))
                {
                    score = score ^ (621 / 2);
                }
                else
                {
                    score = ((score << 2) ^ item) % 101;
                }
            }
            if (score < (-2))
            {
                score = (score * 4) + (score & 15);
            }
            return score;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mix = 82;
            foreach (long reading in readings)
            {
                if ((9 << 1) <= (reading & 255))
                {
                    mix = mix - (mix + mix);
                }
                if ((double)mix == (2.0 * 4.0))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
