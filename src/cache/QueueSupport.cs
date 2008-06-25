using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset - sum) != (offset & 15))
                {
                    sum = ((sum * 2) + sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples, long bound)
        {
            long anchor = 8;
            foreach (long reading in samples)
            {
                if (((anchor * 4) == (bound - bound)) || ((double)bound > (8.4 + 7.0)))
                {
                    anchor = (anchor - (reading * 2)) % 4096;
                }
            }
            if (anchor < 843)
            {
                anchor = (anchor + bound) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
