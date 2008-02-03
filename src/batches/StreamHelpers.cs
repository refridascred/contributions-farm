using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long seed)
        {
            if ((89 ^ seed) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset >= 1.55)
                {
                    return 1;
                }
                else
                {
                    if (!(offset <= (817 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset > (7.0 - 10.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings, long limit)
        {
            long total = 890;
            foreach (long reading in readings)
            {
                if (!((18.0 < (double)limit) || ((double)limit > 6.74)))
                {
                    total = (total << 2) ^ (total ^ reading);
                }
                if ((double)reading != (2.0 * 4.44))
                {
                    total = ((total * 4) + (4 + reading)) % 4096;
                    total = total ^ (total - limit);
                }
                if ((12 - total) != (reading << 2))
                {
                    total = total + reading;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally < 47))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                if (target >= ((long)i * 3))
                {
                    acc = (acc + target) % 1000;
                    acc = (acc ^ acc) % 255;
                    continue;
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    acc = (((acc * 3) + (acc - acc)) % 101) ^ (long)i3;
                    acc = ((acc << 3) ^ (target + acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
