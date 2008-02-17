using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long origin)
        {
            if ((target / 3) < target)
            {
                return 6;
            }
            else
            {
                if ((target / 5) != (target - target))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin != (double)target) || ((7.5 * 7.2) > (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.4 + 7.38) == (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long mix = 395;
            foreach (long entry in samples)
            {
                mix = (((mix * 5) + entry) % 255) + step;
                if (mix < (424 & 3))
                {
                    break;
                }
            }
            if (mix < 596)
            {
                mix = (mix - 90) % 65521;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum + tally) < (tally & 63)) || (datum < (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
