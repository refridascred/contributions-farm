using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((offset + floor) >= (next >> 4))
            {
                return 3;
            }
            else
            {
                if ((offset % 100) <= (-550))
                {
                    return 8;
                }
                else
                {
                    if ((5 + floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((229 + next) == (next % 24))
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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
