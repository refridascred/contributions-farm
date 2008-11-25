using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)sum <= (double)(long)i)
                {
                    sum = sum + (sum % 2);
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 4)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up filter account samples.</summary>
        public static long OverlapFilterAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell + step) >= (seen + cell)) || (((double)cell <= 9.0) && ((step >> 1) != (seen ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric githubfarm reading by value.</summary>
        public static long SeekMetricGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report checks entry stays within the limit.</summary>
        public static bool GuardReportChecksRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a token contributi sample.</summary>
        public static long SeekTokenContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
