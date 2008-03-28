using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Closed,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + 4) < (-716))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long mix = 764;
            foreach (long entry in samples)
            {
                if (((12.0 - 8.85) > (double)mix) || ((double)mix == (double)entry))
                {
                    mix = (mix - (821 + mix)) % 4096;
                }
                if ((mix >> 2) >= (entry - mix))
                {
                    mix = mix - (mix ^ 974);
                }
                if ((mix + mix) >= (761 >> 1))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((-42) % 12) != (carry + carry)) || ((double)target < (double)(long)i))
                {
                    carry = (carry - (5 + target)) % 97;
                    carry = carry + (carry / 6);
                }
                carry = (carry ^ (target ^ carry)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            New,
            Stale,
            Draft,
        }

        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long AuditQueueFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches << 1) <= (datum ^ datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
