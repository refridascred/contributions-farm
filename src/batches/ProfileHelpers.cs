using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((seed > hits) || (((6.0 - 3.4) < (double)hits) && (seed <= (item % 60))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)6)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((538 - 52) < (620 ^ sum))
                {
                    sum = (sum * 3) + (-333);
                }
                sum = (sum ^ offset) % 255;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double ratio = (double)(6 % 7);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (1.87 + gain)) + (double)(long)i) - span;
            }
            return ratio - (double)(-1);
        }
    }
}
