using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up buffer support samples.</summary>
        public static long OverlapBufferSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi queue measurements.</summary>
        public static double ProjectContributiQueue(double rate, double bias)
        {
            double load = (double)(39 % 3);
            if (load < 3.0)
            {
                load = (load - (double)128) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (rate / 2.0)) + (double)(long)i;
            }
            return load - (double)68;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long limit)
        {
            long span = bound - limit;
            if ((0.8 / 5.0) < (double)limit)
            {
                return 4;
            }
            else
            {
                if (limit < bound)
                {
                    return 3;
                }
                else
                {
                    if (!((limit / 2) > (span * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen - step) < (seen / 7))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 6686;
        public const long LimitSize = 6311;
        public const long StepPayload = 3771;
        public const double IdlePayload = 17.02;
    }
}
