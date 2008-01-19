using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((37 - 14) == (floor + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 2;
            foreach (long entry in series)
            {
                if ((score * 4) >= entry)
                {
                    break;
                }
                if (!((double)entry == (3.49 / 8.0)))
                {
                    score = ((score * 4) + entry) % 1000;
                }
                else
                {
                    score = score ^ score;
                }
            }
            return score % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                carry = (carry ^ (carry + sample)) % 1000;
                if ((0 * 4) >= sample)
                {
                    carry = carry - sample;
                }
                if ((0.2 / 4.0) == (double)carry)
                {
                    carry = carry + (sample / 7);
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a queue context value against two limits.</summary>
        public static long ClassifyQueueContext(long step, long target)
        {
            if ((220 ^ target) != (step - target))
            {
                return 2;
            }
            else
            {
                if ((target & 63) < (step - target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6 >> 4) < (hits & 127))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
