using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] samples)
        {
            long mark = 58;
            foreach (long sample in samples)
            {
                if ((mark >> 1) > mark)
                {
                    mark = mark + (sample + mark);
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
                if ((double)mark == (double)sample)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long result = 215;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ (30 >> 5);
                if (((double)result >= (double)4) || ((seed / 4) < entry))
                {
                    result = (result + (entry % 3)) % 255;
                    result = result ^ (entry << 3);
                }
                if ((3 * 3) <= (seed / 4))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (entry >> 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long origin)
        {
            long edge = target - origin;
            if ((double)11 != (double)edge)
            {
                return 5;
            }
            else
            {
                if (((target & 7) != (target - edge)) || (target >= (target - 83)))
                {
                    return 2;
                }
                else
                {
                    if (!(edge >= (edge - edge)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)edge >= (15.0 / 5.0)) || ((edge - edge) <= edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long AuditQueuePayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) != (step / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((516 ^ matches) != (matches + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
