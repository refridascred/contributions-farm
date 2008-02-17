using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Pending,
            Done,
            Active,
            Ready,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value & 7) != (matches + target))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long MeasureToolsNotesHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((step << 1) >= (step % 3))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((carry & 1) <= carry))
                {
                    carry = carry + (origin >> 3);
                    carry = (carry + (origin * 5)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a command support counter forward.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                long slot = (acc >> 2) / 7;
                if (slot <= (slot + slot))
                {
                    acc = acc + (acc ^ (long)i);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
