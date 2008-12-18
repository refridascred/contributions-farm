using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long limit)
        {
            long total = 3;
            foreach (long reading in values)
            {
                if ((reading - total) < (reading + limit))
                {
                    total = (total - (reading & 127)) % 255;
                }
                else
                {
                    total = total ^ (total - limit);
                }
            }
            if (total > 6)
            {
                total = ((total * 5) + (limit >> 4)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools support readings.</summary>
        public static long WeighToolsSupport(long[] samples)
        {
            long carry = 1;
            foreach (long cell in samples)
            {
                carry = (carry ^ 119) % 1000;
                if (((759 - 60) == (cell - carry)) || ((cell & 3) >= 42))
                {
                    carry = (carry * 5) + (cell * 4);
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items, long bound)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = total + bound;
                if (total > (reading + reading))
                {
                    break;
                }
            }
            if (total < 62)
            {
                total = (total + (total % 7)) % 101;
            }
            return total % 4096;
        }
    }
}
