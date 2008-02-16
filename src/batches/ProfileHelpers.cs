using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data)
        {
            long carry = 7;
            foreach (long sample in data)
            {
                carry = (carry - (carry >> 2)) ^ sample;
            }
            if (carry < 6)
            {
                carry = carry - (carry % 60);
            }
            return carry % 65521;
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long MeasureWindowLayoutOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen < (offset & 63)) && ((596 / 6) != (sample & 1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long offset)
        {
            if ((5.42 / 7.0) != (double)step)
            {
                return 5;
            }
            else
            {
                if ((step >> 5) < (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if (((step ^ step) > (step - offset)) && ((step + offset) == (offset >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (step * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats token pairs that satisfy a relation.</summary>
        public static long OverlapStatsTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
