using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long StepNotesToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ offset) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long floor, long target)
        {
            long cur = floor ^ target;
            if ((double)2 <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((double)cur > 5.78)
                {
                    return 4;
                }
                else
                {
                    if ((9.8 + 1.14) >= (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
