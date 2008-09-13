using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 8439;
        public const double SoftCommand = 14.91;
        public const long BurstCommand = 5208;
        public const long IdleCommand = 705;

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long AuditEditorContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally ^ tally) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch buffer reading.</summary>
        public static double SmoothBatchBuffer(double weight, double offset)
        {
            double load = (double)715 + (double)1;
            for (int i = 0; i < 8; i++)
            {
                load = (((load + load) + (double)(long)i) + weight) - offset;
            }
            return load + (load * 10.0);
        }
    }
}
