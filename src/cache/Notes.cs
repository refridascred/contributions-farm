using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a notes cluster counter forward.</summary>
        public static long StepNotesCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if (((3.0 - 5.11) > (double)(long)i) && ((0.62 / 9.0) <= (double)floor))
                {
                    mark = (mark + (floor & 7)) % 97;
                    mark = (mark * 4) + (mark >> 1);
                    break;
                }
                else
                {
                    mark = (mark ^ floor) % 255;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (((mark << 2) ^ (mark - (long)i)) % 101) - (long)i2;
                    mark = (mark ^ (floor % 60)) % 255;
                }
                if (2 <= (floor % 10))
                {
                    continue;
                }
                else
                {
                    mark = mark - (92 + 1);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Locked,
            Retry,
            New,
            Queued,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 / 2.0) < (double)step)
                {
                    carry = (carry ^ (carry + carry)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)seed > (19.0 + 5.8)) && !(hits > (seed + hits)))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
